# Don't do anything if the staging folder is empty
if (-not (Get-ChildItem -path "/root/reformedhistory/staging/" -Recurse | Select-Object -First 1)) {
        Write-Output "Staging directory is empty, skipping deployment"
        return
}

# Stop the website
Invoke-Expression "sudo systemctl stop reformedhistory.service"

# Delete everything in the deployment directory
Remove-Item -Path "/root/reformedhistory/deploy/*" -Recurse -Force

# Copy everything from staging to deployment
Copy-Item -Path "/root/reformedhistory/staging/*" -Destination "/root/reformedhistory/deploy/" -Recurse -Force

# Delete everything in the staging directory to make space for the next action 
Remove-Item -Path "/root/reformedhistory/staging/*" -Recurse -Force

# Start the website again
Invoke-Expression "sudo systemctl start reformedhistory.service"

Write-Output "Deployment complete"