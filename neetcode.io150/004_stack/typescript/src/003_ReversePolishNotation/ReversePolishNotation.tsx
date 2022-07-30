/* 
    Evaluate the value of an arithmetic expression in Reverse Polish Notation.

    Valid operators are +, -, *, and /. Each operand may be an integer or another expression.

    Note that division between two integers should truncate toward zero.

    It is guaranteed that the given RPN expression is always valid. That means the expression would always evaluate to a result, and there will not be any division by zero operation.

 

    Example 1:

    Input: tokens = ["2","1","+","3","*"]
    Output: 9
    Explanation: ((2 + 1) * 3) = 9
    Example 2:

    Input: tokens = ["4","13","5","/","+"]
    Output: 6
    Explanation: (4 + (13 / 5)) = 6
    Example 3:

    Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
    Output: 22
    Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
    = ((10 * (6 / (12 * -11))) + 17) + 5
    = ((10 * (6 / -132)) + 17) + 5
    = ((10 * 0) + 17) + 5
    = (0 + 17) + 5
    = 17 + 5
    = 22
*/

function evalRPN(tokens: string[]) {

    const OPERATORS: {[key: string]: ((a: number, b:number) => number)} = {
        '+': (a:number, b:number) => a + b,
        '-': (a:number, b:number) => a - b,
        '*': (a:number, b:number) => a * b,
        '/': (a:number, b:number) => Math.trunc(a / b),
    };

    let stack: any[] = []

    tokens.forEach((i) => {

        if(i in OPERATORS){

            let rightSide = stack.pop()
            let leftSide = stack.pop()

            stack.push(OPERATORS[i](leftSide, rightSide));
        } else {
            stack.push(parseInt(i));
        

        }

        
    
    })

    return stack.pop()

};

console.log(evalRPN(["2","1","+","3","*"]))
console.log(evalRPN(["4","13","5","/","+"])) // shold be 6

