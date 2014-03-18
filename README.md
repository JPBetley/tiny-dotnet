# Tiny
[![Build Status](https://travis-ci.org/JPBetley/tiny-dotnet.png?branch=master)](https://travis-ci.org/JPBetley/tiny-dotnet)

A reversible base62 ID obfuscater

## Authors

Originally by Jacob DeHart, with Ruby and Python ports by Kyle Bragger.

Derived from the PHP implementation by [Zack Kitzmiller](https://github.com/zackkitzmiller).

## Installation

Install via NuGet
```
PM> Install-Package JPBetley.Tiny-DotNet
```

## Usage

```
var tiny = new Tiny("5SX0TEjkR1mLOw8Gvq2VyJxIFhgCAYidrclDWaM3so9bfzZpuUenKtP74QNH6B");

tiny.To(5);
// E

tiny.From("E");
// 5
```

## Tested with Mono
All testing during development is done on the Windows .NET platform. 
Travis is used as an extra layer of testing, but uses the [Mono](http://www.mono-project.com/Main_Page) library.
Now you can rest assured that Tiny is available on both platforms.