#!/bin/bash

# Define the categories and their respective documents
categories=("Councils" "Letters" "Documents")

councils=(
    "Council of Nicea (325)"
    "First Council of Constantinople (381)"
    "Council of Ephesus (431)"
    "Council of Chalcedon (451)"
    "Second Council of Constantinople (553)"
    "Third Council of Constantinople (680)"
    "Council of Frankfurt (794)"
    "Synod of Chanforan (1532)"
    "Synod of Dort (1618)"
    "Glasgow General Assembly (1638)"
    "Westminster Assembly (1643)"
)

letters=(
    "Epistle of Clement to the Corinthians"
    "Epistles of Ignatius"
    "Epistles of Polycarp"
    "Epistle of St Leo to Flavian"
)

documents=(
    "The Didache"
    "Apostles Creed"
    "Nicean Creed"
    "Chalcedonian Definition"
    "Westminster Confession"
    "Scots Confession"
    "Belgic Confession"
    "Heidelberg Catechism"
    "Helvetic Confessions"
)

# Function to create Razor page files
create_razor_page() {
    category=$1
    document=$2
    folder_name=$category
    file_name=$(echo $document | tr -d ' ()')
    directory_path="Pages/$folder_name"
    cshtml_path="$directory_path/$file_name.cshtml"
    cshtml_cs_path="$directory_path/$file_name.cshtml.cs"
    namespace="ReformedHistory.Pages.$folder_name"

    # Create directory if it doesn't exist
    mkdir -p $directory_path

    # Create .cshtml file
    cat <<EOL > $cshtml_path
@page
@model $namespace.${file_name}Model
@{
    Layout = null;
}

<h1 class="text-2xl font-bold">$document</h1>
<p>
    <!-- Insert the full text of $document here -->
</p>
EOL

    # Create .cshtml.cs file
    cat <<EOL > $cshtml_cs_path
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace $namespace
{
    public class ${file_name}Model : PageModel
    {
        public void OnGet()
        {
        }
    }
}
EOL
}

# Create Razor pages for councils
for document in "${councils[@]}"; do
    create_razor_page "Councils" "$document"
done

# Create Razor pages for letters
for document in "${letters[@]}"; do
    create_razor_page "Letters" "$document"
done

# Create Razor pages for documents
for document in "${documents[@]}"; do
    create_razor_page "Documents" "$document"
done

echo "Document pages generated successfully."

