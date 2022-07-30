/* 
    There is an integer array nums sorted in ascending order (with distinct values).

    Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

    Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

    You must write an algorithm with O(log n) runtime complexity.

    

    Example 1:

        Input: nums = [4,5,6,7,0,1,2], target = 0
        Output: 4

    Example 2:

        Input: nums = [4,5,6,7,0,1,2], target = 3
        Output: -1

    Example 3:

        Input: nums = [1], target = 0
        Output: -1
    

    Constraints:

        1 <= nums.length <= 5000
        -104 <= nums[i] <= 104
        All values of nums are unique.
        nums is an ascending array that is possibly rotated.
        -104 <= target <= 104
*/

// Find the pivot
    // Find middlepoint
    // if middlepoint, is more than endpoint there was a pivot

function search(nums: number[], target: number){

    let startIndex = 0;
    let endIndex = nums.length - 1;

    while (startIndex <= endIndex) {
        let mid = Math.floor((startIndex + endIndex) / 2);

        if (nums[mid] === target) {
            return mid;
        }

        // Checking if the startIndex side is sorted
        if (nums[startIndex] <= nums[mid]) {
            if (nums[startIndex] <= target && target <= nums[mid]) {
                // thus target is in the startIndex
                endIndex = mid - 1;
            } else {
                // thus target is in the endIndex
                startIndex = mid + 1;
            }
        }

        // Otherwise, the endIndex side is sorted
        else {
            if (nums[mid] <= target && target <= nums[endIndex]) {
                // thus target is in the endIndex
                startIndex = mid + 1;
            } else {
                // thus target is in the startIndex
                endIndex = mid - 1;
            }
        }
    }

    return -1;
};

console.log(search([4,5,6,7,0,1,2], 0))
console.log(search([2,1,0,4,5,6,7], 1))

