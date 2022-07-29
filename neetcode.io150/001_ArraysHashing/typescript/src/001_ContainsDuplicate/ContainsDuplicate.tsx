
/* Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct. */

function containsDuplicate(nums: number[]): boolean {

    let trackKeeper:{[key: number]: number} = {};

    for(let i = 0; i < nums.length; i++){

        if(trackKeeper[nums[i]] === undefined){

            trackKeeper[nums[i]] = 1
        }else{

            return true
        }



    }

    return false

}

containsDuplicate([1,1,1,3,3,4,3,2,4,2])


