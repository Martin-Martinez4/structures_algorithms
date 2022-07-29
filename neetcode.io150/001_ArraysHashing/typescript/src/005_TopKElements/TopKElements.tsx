/* 
    Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

    Example 1:

        Input: nums = [1,1,1,2,2,3], k = 2
        Output: [1,2]
    Example 2:

        Input: nums = [1], k = 1
        Output: [1]
    

    Constraints:

        1 <= nums.length <= 105
        k is in the range [1, the number of unique elements in the array].
        It is guaranteed that the answer is unique.
    
*/

// k = 2 means 2nd most frequent, return 1st and 2nd most frequent
// hash {index arrayValue: timesSeen}

// Brute Force

function topKFrequent(nums: number[], k: number): number[] {

    let tempObject: {[key: number]: number} = {};

    for(const number of nums){
        
        if(tempObject[number] === undefined){
            tempObject[number] = 0
        }
            
        tempObject[number] += 1;

    }

    const sortedArray = Object.entries(tempObject).sort(function(a, b){
        return b[1]-a[1];
    });

    console.log(sortedArray)

    let tempArray: number[] = [];

    for(let i = 0; i < k; i++){
    
        tempArray.push(parseInt(sortedArray[i][0]))

    }

    return tempArray

};

const nums = [1,1,1,2,2,3] 
const k = 2;

const nums2 = [1,1,1,2,2,3] 
const k2 = 3;

topKFrequent(nums, k)

// After looking at neetCode response
// of course buckets

function topKFrequent2(nums: number[], k: number) {

    let tempObject: {[key: number]: number} = {};
    let res: Partial<number[]> = []
    let bucket:number[][] = Array.from({ length: nums.length + 1 }, () => []);

    for(const number of nums){
        
        if(tempObject[number] === undefined){
            tempObject[number] = 0
        }
            
        tempObject[number] += 1;

    }

    for(const key in tempObject){

        bucket[tempObject[key]].push(parseInt(key))

    }

    console.log(bucket);

    for(let i = bucket.length -1; i > 0; i--){

        if(bucket[i].length > 0){

            bucket[i].forEach(value => {res.push(value)})

            k--

            if(k <= 0){

                return res
            }

        }

    }


};

const test = topKFrequent2(nums, k)
const test2 = topKFrequent2(nums2, k2)

console.log(test)
console.log(test2)

