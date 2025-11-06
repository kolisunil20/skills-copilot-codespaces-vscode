# Fibonacci Series Generator

This repository contains implementations of a Fibonacci series generator that produces all Fibonacci numbers in the range from 1 to 1000.

## What is Fibonacci Series?

The Fibonacci series is a sequence of numbers where each number is the sum of the two preceding ones. The sequence typically starts with 0 and 1, and continues as: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...

## Implementations

### JavaScript Version

**File:** `fibonacci.js`

**Run:**
```bash
node fibonacci.js
```

### Python Version

**File:** `fibonacci.py`

**Run:**
```bash
python3 fibonacci.py
```

## Output

Both implementations generate the following Fibonacci numbers in the range [1, 1000]:

```
1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987
```

**Total count:** 16 numbers

## How it Works

The algorithm:
1. Starts with two initial values: a = 0, b = 1
2. Generates the next Fibonacci number by adding the previous two numbers
3. Continues until the next number would exceed 1000
4. Only includes numbers in the range [1, 1000]

## Features

- ✅ Generates all Fibonacci numbers between 1 and 1000
- ✅ Clean, well-documented code
- ✅ Available in both JavaScript and Python
- ✅ Displays results in a readable format
- ✅ Shows the total count of generated numbers
