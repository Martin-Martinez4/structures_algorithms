/* 
    Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

    Example 1:
        Input: n = 3
        Output: ["((()))","(()())","(())()","()(())","()()()"]

    Example 2:

        Input: n = 1
        Output: ["()"]
*/

// Use backtracking

// function backtracking(stringArray: string[], currentString: string, open:number, close:number, max:number){

//     if(currentString.length === max*2){

//         stringArray.push(currentString);
//         return;
//     }

//     if(open < max){
//         backtracking(stringArray, currentString + "(", open +1, close, max)
//     }
//     if(close > open){
//         backtracking(stringArray, currentString + ")", open, close+ 1, max)
//     }

// }

function generateParenthesis(n: number){

    function backtracking(stringArray: string[], currentString: string, open:number, close:number, max:number){

        if(currentString.length === max*2){
    
            stringArray.push(currentString);
            return;
        }
    
        if(open < max){
            backtracking(stringArray, currentString + "(", open +1, close, max)
        }
        if(close < open){
            backtracking(stringArray, currentString + ")", open, close+ 1, max)
        }
    
    }

    let outputArray: string[] = [];

    backtracking(outputArray, "", 0,0, n )

    return outputArray;

};


