$stagingDir = "/root/reformedhistory/staging"
$deployDir = "/root/reformedhistory/deploy"
$serviceName = "reformedhistory.service"

# Don't do anything if the staging folder is empty
if (-not (Get-ChildItem -path $stagingDir -Recurse | Select-Object -First 1)) {
        Write-Output "Staging directory is empty, skipping deployment"
        return
}

# Stop the website
Invoke-Expression "sudo systemctl stop ${serviceName}"

# Delete everything in the deployment directory
Remove-Item -Path "${deployDir}/*" -Recurse -Force

# Copy everything from staging to deployment
Copy-Item -Path "${stagingDir}/*" -Destination $deployDir -Recurse -Force

# Delete everything in the staging directory to make space for the next action 
Remove-Item -Path "${stagingDir}/*" -Recurse -Force

# Start the website again
Invoke-Expression "sudo systemctl start ${serviceName}"

Write-Output "Deployment complete"