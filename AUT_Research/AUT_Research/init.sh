#!/bin/zsh

# This script sets up the environment for Java and ANTLR development on macOS.
# Make sure to modify the paths to match your actual Java and ANTLR locations.

# Set Java and ANTLR paths
export CLASSPATH=".:obj:lib/antlr-4.13.2-complete.jar:$CLASSPATH"

# Define aliases to simulate doskey macros
alias a4='java org.antlr.v4.Tool HomeGrammar.g4 -o gen'
alias a4v='java org.antlr.v4.Tool HomeGrammar.g4 -no-listener -visitor -o gen'
jc() {
  javac gen/HomeGrammar*.java Main.java -d obj
}
alias grun='java org.antlr.v4.gui.TestRig HomeGrammar prog -gui input.txt'
alias run='java Main $L input.txt'
alias clean='rm -rf gen/* obj/*'


