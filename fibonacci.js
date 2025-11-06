/**
 * Fibonacci Series Generator
 * Generates Fibonacci numbers in the range from 1 to 1000
 */

/**
 * Generates Fibonacci series with numbers in the range [1, 1000]
 * @returns {Array<number>} Array of Fibonacci numbers between 1 and 1000
 */
function generateFibonacciSeries() {
    const fibonacciNumbers = [];
    let a = 0;
    let b = 1;
    
    // Generate Fibonacci numbers until we exceed 1000
    while (b <= 1000) {
        if (b >= 1) {
            fibonacciNumbers.push(b);
        }
        const next = a + b;
        a = b;
        b = next;
    }
    
    return fibonacciNumbers;
}

// Generate and display the Fibonacci series
const fibonacciSeries = generateFibonacciSeries();

console.log('Fibonacci Series (numbers from 1 to 1000):');
console.log(fibonacciSeries.join(', '));
console.log(`\nTotal count: ${fibonacciSeries.length} numbers`);

// Export for use in other modules (if needed)
if (typeof module !== 'undefined' && module.exports) {
    module.exports = { generateFibonacciSeries };
}
