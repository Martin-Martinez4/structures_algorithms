/* 
    A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

    Given a string s, return true if it is a palindrome, or false otherwise
*/

// Old Answer
// function isPalindrome(s: string): boolean {

//     const cleanedString: string = s.toLowerCase().replace(/[^a-zA-Z0-9]+/g, "") 

//     const middlePoint: number = Math.ceil((cleanedString.length)/2)

//     let frontPointer: number = 0;
//     let backPointer: number = cleanedString.length -1;

//     for(let i = 0; i < middlePoint; i++){

//         if(cleanedString[frontPointer] !==  cleanedString[backPointer]){

//             return false;
//         }

//         frontPointer++;
//         backPointer--

//     }



//     return true

// };

// Old way was faster?
function isPalindrome(s: string): boolean {

    const cleanedString: string = s.toLowerCase().replace(/[^a-zA-Z0-9]+/g, "") 

    let frontPointer: number = 0;
    let backPointer: number = cleanedString.length -1;

    while (frontPointer <= backPointer){

        if(cleanedString[frontPointer] !==  cleanedString[backPointer]){

            return false;
        }

        frontPointer++
        backPointer--

    }

    return true

};


