# Running Tests

## Setup the tests
Currently, we use xUnit as it is the only test framework that has
a runner for DNX. That's only because it's the one used internaly
by the aspnet team (but I also have a work in progress [Iago](https://github.com/rhwy/iago)
which is more C#6 and BDD friendly ;-))

When you setup the runner in the `project.json` file, it will pull
also the lib for writing the tests.

I also use here the `NFluent` lib because I use to and because it
allows you to write much smoother tests ;-).

The only thing to do to write tests as you can see in the code with
xUnit is to put a cs file with a class and adding `[Fact]` to the
methods we want to consider as tests. Then you just run the tests
with `dnx test`.

## Continuous Tests

Continuous testing is just another step in optimizing your feedback
loop while doing TDD that is really hard to avoid when you start using
it. Within VisualStudio, there is great plugins like `NCrunch` but here
with the DNX runtime, from command line, you can achieve that in a much
simpler way.

As actually none of the file watchers is working very well on Macosx, I
build my own called [Watchbird](https://www.nuget.org/packages/Watchbird/).

It is specifically build for dnx451, that means he know how to lunch dnx commands,
but it is also able to lunch system commands, and more important it works on .Net and mono.

You just have to add the dependency to your `project.json`

        "Watchbird": "1.0.0-rc1-2"

And then add the command to run instead of tests to watch the folder:

        "commands": {
            "test": "xunit.runner.aspnet",
            "watch":"watchbird --dnx=xunit.runner.aspnet"
        }
            
To start working on your tests with continuous testing, 
you just have to launch the `watch` command of
our `project.json`.

    dnx watch

Now you can write your tests while having an immediate feedback!

Hit `esc` to quit the watch.
