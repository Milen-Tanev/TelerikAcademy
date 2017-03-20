/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
	return function findPrimes(start, end) {
		if(+start || +start === 0){
			start = +start;
			if(start < 2) {
				start = 2;
			} 
		} else {
			throw new Error;
		}

		if(+end) {
			end = +end;
		} else {
			throw new Error;
		}
		let isPrime = true;
		let result = [];
		for(i = start; i <= end; i += 1){
			let maxDiv = Math.floor(Math.sqrt(i));
			let isPrime = true;
			for(j = 2; j <= maxDiv; j += 1){
				if(i % j === 0){
					isPrime = false;
					break;
				}
			}
			if(isPrime){
				result.push(i);
			}
		}
		return result;
	}
}
module.exports = solve;
