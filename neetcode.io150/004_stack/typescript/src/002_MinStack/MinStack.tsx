/* 
    Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

    Implement the MinStack class:

    MinStack() initializes the stack object.
    void push(int val) pushes the element val onto the stack.
    void pop() removes the element on the top of the stack.
    int top() gets the top element of the stack.
    int getMin() retrieves the minimum element in the stack.
    You must implement a solution with O(1) time complexity for each function.
*/

class MinStack {

    mainStack: number[] = [];
    minStack: number[] = [];

    constructor() {

        this.mainStack = [];
        this.minStack = [];

    }

    getMain(){

        return this.mainStack
    }
    getMinStack(){

        return this.minStack
    }

    push(val: number): void {

        this.mainStack.push(val);
        if(val <= this.minStack[this.minStack.length -1] || this.minStack.length === 0){

            this.minStack.push(val);
        }


    }

    pop(): void {


        const val= this.mainStack.pop()

        if(val === this.minStack[this.minStack.length -1]){

            this.minStack.pop();

        }


    }

    top(): number {


        return this.mainStack[this.mainStack.length -1]

    }

    getMin(): number {

        return this.minStack[this.minStack.length -1]

    }
}


const minStack = new MinStack()

console.log(minStack.getMain());
console.log(minStack.getMin());

minStack.push(11)
minStack.push(10)
minStack.push(-2)
minStack.push(-1)

console.log(minStack.getMain());
console.log(minStack.getMinStack());




