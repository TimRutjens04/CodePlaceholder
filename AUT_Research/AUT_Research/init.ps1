# Set CLASSPATH, append to the existing classpath
$env:CLASSPATH = ".;obj;lib\antlr-4.13.2-complete.jar;$env:CLASSPATH"

# Define a4 function to run ANTLR Tool
function a4 {
    java org.antlr.v4.Tool MyGrammar.g4 -o gen
}

# Define a4v function to run ANTLR Tool with visitor
function a4v {
    java org.antlr.v4.Tool MyGrammar.g4 -no-listener -visitor -o gen
}

# Define jc function to compile the generated Java files and Main.java
function jc {
    javac gen\MyGrammar*.java Main.java -d obj
}

# Define grun function to run TestRig (GUI for testing the parser)
function grun {
    java org.antlr.v4.gui.TestRig MyGrammar myStart -gui input.txt
}

# Define run function to run the main class with input file
function run {
    java Main $L input.txt
}

# Define clean function to delete generated files
function clean {
    Remove-Item -Force -Recurse gen\*, obj\*
}