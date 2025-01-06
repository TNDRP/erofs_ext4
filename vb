#!/bin/bash

echo ""
echo "-------------------------------"
echo "  Patching AVB"
echo "-------------------------------"

vb_path="./stat/vbmeta.img"
vb_s_path="./stat/vbmeta_system.img"

rm -rf ./last/vbmeta.img  > /dev/null 2>&1
rm -rf ./last/vbmeta_system.img  > /dev/null 2>&1

# Check if the file exists
if [ -e "$vb_path" ]; then
    # Use strings to extract printable strings from the binary file
    version_string=$(strings "$vb_path" | grep "1.2.0")

    if [ -n "$version_string" ]; then
        echo "  $version_string"
        cp ./prebuilt/1.2/vbmeta.img ./last
    else
        echo "  $vb_path"
        cp ./prebuilt/1.1/vbmeta.img ./last
    fi
else
    echo "  File not found"
fi

# Check if the file exists
if [ -e "$vb_s_path" ]; then
    # Use strings to extract printable strings from the binary file
    version_string1=$(strings "$vb_s_path" | grep "1.2.0")

    if [ -n "$version_string1" ]; then
        echo "  $version_string1"
        cp ./prebuilt/1.2/vbmeta_system.img ./last
    else
        echo "  $vb_s_path"
        cp ./prebuilt/1.1/vbmeta_system.img ./last
    fi
else
    echo "  File not found"
fi

echo ""
echo "-------------------------------"
echo "  Done"
echo "-------------------------------"