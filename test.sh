#!/bin/bash

file_to_copy="super.img"
destination_folder="./rom"

# Check if the file exists
if [ -e "$file_to_copy" ]; then
    # Copy the file to the destination folder
    cp "$file_to_copy" "$destination_folder/"
    echo "File copied to $destination_folder/"
else
    echo "File not found: $file_to_copy"
fi

./row