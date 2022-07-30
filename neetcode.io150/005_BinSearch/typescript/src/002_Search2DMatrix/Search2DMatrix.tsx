/* 
    Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. This matrix has the following properties:

    Integers in each row are sorted from left to right.
    The first integer of each row is greater than the last integer of the previous row.
    

    Example 1:


        Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
        Output: true

    Example 2:

        Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
        Output: false
*/

// Sorted matrix Binary Search

    //  First pass reduce to one row
        // if row[0] < target and row[row.length -1] > target choose row

function searchMatrix(matrix: number[][], target: number): boolean {

    let targetIndex: number[][];

    targetIndex = matrix.filter((row, index) => {

        if(row[0] <= target && row[row.length -1] >= target){

            return row
        }

    })

    if(targetIndex.length === 0){

        return false;
    }

    let nums = targetIndex[0]
    let endPoint = nums.length -1;
    let startPoint = 0;
    let middlePoint = Math.floor((endPoint + startPoint) /2);

    while(startPoint < endPoint){

        if(nums[middlePoint] === target){

            return true

        }else if(nums[middlePoint] < target){

            startPoint = middlePoint + 1;

        }else if(nums[middlePoint] > target){

            endPoint = middlePoint;
        }

        middlePoint = Math.floor((endPoint + startPoint) /2);

    }

    return nums[startPoint] === target ? true : false;

};

console.log(searchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]], 3))
console.log(searchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]], 13))
