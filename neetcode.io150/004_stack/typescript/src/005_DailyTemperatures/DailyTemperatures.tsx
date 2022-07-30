/* 
    Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

    Example 1:

        Input: temperatures = [73,74,75,71,69,72,76,73]
        Output: [1,1,4,2,1,1,0,0]

    Example 2:

        Input: temperatures = [30,40,50,60]
        Output: [1,1,1,0]

    Example 3:

        Input: temperatures = [30,60,90]
        Output: [1,1,0]
*/

// Brute force 
// function dailyTemperatures(temperatures: number[]){

//     const resArray: number[] = []

//     for(let i = 0; i < temperatures.length; i++){

//         let j = i;

//         resArray.push(0);

//         while(j < temperatures.length){

//             if(temperatures[j] > temperatures[i]){

//                 resArray[i] = j -i;

//                 break

//             }

//             j++

//         }

//     }

//     return resArray;

// };

// Manged to make it slower? 
function dailyTemperatures(temperatures: number[]){

    const output:number[] = Array(temperatures.length).fill(0);

    const stack:number[][] = [];
    

    for(let i = 0; i < temperatures.length; i++){

        while(stack.length !== 0 && stack[stack.length - 1][0] < temperatures[i]){
            
            const tempArray: number[] | undefined = stack.pop();

            if(tempArray)
            output[tempArray[1]] = i - tempArray[1];
        }

        stack.push([temperatures[i], i])

    }

    console.log(stack)

    return output;

};

// console.log(dailyTemperatures([73,74,75,71,69,72,76,73]));
console.log(dailyTemperatures([30,40,50,60]))

// How to Stack it?


