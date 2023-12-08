#!/bin/bash

# Define our function
function check_file() {
    projectPath=$1
    filePath=$2

    # Check if the file exists
    if [ -f "$filePath" ]; then
        # Loop through each line
        while IFS= read -r line
        do
            # Execute the dotnet command with the line as a parameter
            dotnet run --project "$projectPath" "$line"
        done < "$filePath"
    else
        echo "File not found: $filePath"
    fi
}

# Call our function with the first script parameter
check_file "$1" "$2"