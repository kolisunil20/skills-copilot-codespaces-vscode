"""
Fibonacci Series Generator
Generates Fibonacci numbers in the range from 1 to 1000
"""

def generate_fibonacci_series():
    """
    Generates Fibonacci series with numbers in the range [1, 1000]
    
    Returns:
        list: List of Fibonacci numbers between 1 and 1000
    """
    fibonacci_numbers = []
    a, b = 0, 1
    
    # Generate Fibonacci numbers until we exceed 1000
    while b <= 1000:
        if b >= 1:
            fibonacci_numbers.append(b)
        a, b = b, a + b
    
    return fibonacci_numbers


if __name__ == "__main__":
    # Generate and display the Fibonacci series
    fibonacci_series = generate_fibonacci_series()
    
    print("Fibonacci Series (numbers from 1 to 1000):")
    print(", ".join(map(str, fibonacci_series)))
    print(f"\nTotal count: {len(fibonacci_series)} numbers")
