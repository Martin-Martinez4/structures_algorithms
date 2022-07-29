/*
    Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

    You must write an algorithm that runs in O(n) time and without using the division operation.

    Example 1:

        Input: nums = [1,2,3,4]
        Output: [24,12,8,6]
    Example 2:

        Input: nums = [-1,1,0,-3,3]
        Output: [0,0,9,0,0]
*/

// cache results 

function productExceptSelf(nums: number[]): number[] {

    let res: number[] = [];
    let tempArrays: number[][] = []

    for(let i = 0; i < nums.length; i++){

        let tempArray = [...nums]

        tempArray.splice(i, 1);

        tempArrays.push(tempArray)
        
    }
    
    for(let j = 0; j < tempArrays.length; j++){

        res.push(tempArrays[j].reduce((total, num) => {
    
            return total*num
    
        }))
    
    };
    return res;
}

// console.log( productExceptSelf([-1,1,0,-3,3]))
// console.log( productExceptSelf([1,2,3,4]))

const productExceptSelf2 = function(nums: number[]): number[]  {
    const res: number[] = [];

    let product:number = 1;

    for (let i = 0; i < nums.length; i++) {

        res[i] = product;

        product *= nums[i];
    }

    product = 1;
    for (let j = nums.length - 1; j >= 0; j--) {
        res[j] *= product;
        product *= nums[j];
    }

    return res;
};

console.log( productExceptSelf2([-1,1,0,-3,3]))
console.log( productExceptSelf2([1,2,3,4]))