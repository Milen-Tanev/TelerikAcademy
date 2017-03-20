/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve() {
    return function sum(arr){
        if(!Array.isArray(arr)){
            throw new Error;
        } else if(arr.length === 0){
            return null;
        }
        let sum = 0;
        arr.forEach(function(el){
			if(parseInt(el)){
                sum += +el;
            } else{
                throw new Error;
            }
        });
        return sum;
    }
}

module.exports = solve;
