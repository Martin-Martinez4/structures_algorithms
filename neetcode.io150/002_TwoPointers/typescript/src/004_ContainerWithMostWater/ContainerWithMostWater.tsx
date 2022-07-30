/* 
    You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

    Find two lines that together with the x-axis form a container, such that the container contains the most water.

    Return the maximum amount of water a container can store.

    Notice that you may not slant the container.

    Example 1:
        Input: height = [1,8,6,2,5,4,8,3,7]
        Output: 49
        Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

        i  = 0; height1 = 1; height[1] = 8, width = abs(0 - 1) min-height = 1; capcity = min-height * width = 1 * 1 = 1
        i = 1; height = 8; height[8] = 7; width = abs(1 - 8); min-height  = 7; capcity = min-height * width = 7 * 7 = 49

    Example 2 [1,2,1] Expect 2

        i = 0; height1[i]: 1; height[height[i]] = height[1] = 2; width = abs(i - height[i]) = abs(0 - 1) = 1; min-height = 1; ans = 1 * 1 = 2 
        i = 1; height[i]: 2; height[height[i]] = 1; min-height = 1; width = abs(1 - 2); volume = 1 * 1
        i = 2; height[i]: 1; height[height[i]] = 2; min-height = 1; width = abs(1 - 2); volume = 1 * 1

*/

// Nevermind it is simpler only account for the lenght

// function maxArea(height: number[]){

//     let currMax: number = 0;

//     let height1: number;
//     let height2: number;

//     let width: number;
    
//     for(let i = 0; i < height.length; i++){

//         let minHeight = 0;

//         height1 = height[i]
//         height2 = height[height[i]];

//         if(height1 < height2){

//             minHeight = height1
//         }else{
//             minHeight = height2
//         }

//         width = Math.abs(i -  height[i]);

//         console.log(i, ": ",width)

//         if(width * minHeight > currMax){

//             currMax = width * minHeight
//         }
    

//     }

//     return currMax

// };

function maxArea(height: number[]):number{

    let globalMax: number = 0;

    let i = 0;
    let j = height.length -1;
    
    while(i < j){

        const localMax = (j - i) * Math.min(height[i], height[j]);

        if(localMax > globalMax){

            globalMax = localMax;
        }

        if(height[i] > height[j]){
            j--
        }else{
            i++
        }


    }

    return globalMax

}


console.log(maxArea([1,8,6,2,5,4,8,3,7]));
console.log(maxArea([1,2,1]));

