#!/bin/bash
export CSCOPE_EDITOR=view
cscope -d -p15 "$@"
