#!/bin/bash

input_files=(./aik/ramdisk/fstab.*)

sudo sed -i 's/erofs/ext4/g' $input_files
