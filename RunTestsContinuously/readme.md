# Running Tests

## Setup the tests
Currently, we use xUnit as it is the only test framework that has
a runner for KRE. That's only because it's the one used internaly
by the aspnet team.

When you setup the runner in the `project.json` file, it will pull
also the lib for writing the tests.

I also use here the `NFluent` lib because I use to and because it
allows you to write much smoother tests ;-).

The only thing to do to write tests as you can see in the code with
xUnit is to put a cs file with a class and adding `[Fact]` to the
methods we want to consider as tests. Then you just run the tests
with `k test`.

## Contiuous Tests

Continuous testing is just another step in optimizing your feedback
loop while doing TDD that is really hard to avoid when you start using
it. Within VisualStudio, there is great plugins like `NCrunch` but here
with the KRE runtime, from command line, you can achieve that in a much
simpler way.

First you need to install `node monitor`, a nodejs app that watch for
your files. This will install it on your system globally:

    sudo npm install -g nodemon

Then we use the `kmon` lib wich is a wrapper around it, just to be able
to call it from `K` as a command.

To start working on your tests, you just have to launch the `ct` command of
our `project.json`.

    k ct

_note: it doesn't scroll down very well, you may need to do it manually
times to times_

Hit `ctrl-C` to quit the node mon.
