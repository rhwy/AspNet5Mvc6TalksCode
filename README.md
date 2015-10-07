# AspNet5Mvc6TalksCode
Some code used during my AspNet 5 and Mvc6 Talks

First of all, go to [Github Asp.Net Home page](https://github.com/aspnet/home)
and follow the instructions to have a proper installation on your
system.

This repo is here to show and teach simple samples that can run
from console on Mac/Linux but you can obviously also open them
on Windows.

I'll try to keep all the projects here up to date with the last
DNX runtime, but feel free to PR me if I missed something, if you want to complete a
demo or add a new one.

# Current Projects

These projects try to serve one objective at a time and stay simple.
Here is the current list:

1. [Minimal AspNet5 project](MinimalAspNet5Project/). This is the starting point. You'll learn to:
    * what are the minimal files needed for a project
    * what is the minimal configuration
    * use the Owin pipeline in the most simple way to return something
    on each request
    * add a very simple middleware to log into the console

2. [Minimal Mvc6 Project](MinimalMvc6Project/). This project is a step further the previous one, it adds the MVC framework
  on top of the AspNet5 project. You'll learn to:

    * view the dependecies in place with MVC6 framework
    * view a minimal configuration
    * add a first route and controller with no views

3. [Run Continuously & tests](RunTestsContinuously/). Simple lib for testing and file watcher. You'll learn to:
    * load test lib
    * lunch the test runner
    * add a tool to do continuous testing while you write your tests (by simply adding a file watcher+test runner)

    
