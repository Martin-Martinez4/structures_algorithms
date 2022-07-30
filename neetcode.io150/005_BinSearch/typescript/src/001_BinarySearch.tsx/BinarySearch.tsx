/* 
    Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

    You must write an algorithm with O(log n) runtime complexity.

    Example 1:

        Input: nums = [-1,0,3,5,9,12], target = 9
        Output: 4
        Explanation: 9 exists in nums and its index is 4

    Example 2:

        Input: nums = [-1,0,3,5,9,12], target = 2
        Output: -1
        Explanation: 2 does not exist in nums so return -1
*/

function search2(nums: number[], target: number){

    let endPoint = nums.length -1;
    let startPoint = 0;
    let middlePoint = Math.floor((endPoint + startPoint) /2);

    while(startPoint < endPoint){

        if(nums[middlePoint] === target){

            return middlePoint

        }else if(nums[middlePoint] < target){

            startPoint = middlePoint + 1;

        }else if(nums[middlePoint] > target){

            endPoint = middlePoint;
        }

        middlePoint = Math.floor((endPoint + startPoint) /2);

    }

    return nums[startPoint] === target ? startPoint : -1;
    
};

console.log(search( [-1,0,3,5,9,12], 9))
console.log(search( [-1,0,3,5,9,12], 2))


