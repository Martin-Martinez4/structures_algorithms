/* 
    Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

    Notice that the solution set must not contain duplicate triplets.

    Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.

    Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.

    Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
*/

function threeSum(nums: number[]){

    const sortedNums = nums.sort((a, b) => {

        return b -a
    })

    let res: number[][] = []

    let frontPointer = 0;
    let endPointer = nums.length -1;

    for(let i = 0; i < nums.length; i++){
        if (nums[i] === nums[i - 1]) continue;

        frontPointer = i + 1;
        endPointer = nums.length - 1;

        while(frontPointer < endPointer){

            if(sortedNums[frontPointer] +  sortedNums[endPointer] + sortedNums[i] === 0){

                res.push([sortedNums[frontPointer], sortedNums[endPointer], sortedNums[i]])

                frontPointer++
                endPointer--

                while (nums[frontPointer] == nums[frontPointer - 1]) {
                    frontPointer++;
                }
    
                while (nums[endPointer] == nums[endPointer + 1]) {
                    endPointer--;
                }
            }


            if(sortedNums[frontPointer] +  sortedNums[endPointer] + sortedNums[i] > 0){
                
                frontPointer++
            }
            if(sortedNums[frontPointer] +  sortedNums[endPointer] + sortedNums[i] < 0){
                
                endPointer--
            }

            console.log(sortedNums[frontPointer] +  sortedNums[endPointer] + sortedNums[i])

        }

    }

    return res

};

console.log(threeSum([-1,0,1,2,-1,-4]))

