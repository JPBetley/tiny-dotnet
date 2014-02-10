# Tiny

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