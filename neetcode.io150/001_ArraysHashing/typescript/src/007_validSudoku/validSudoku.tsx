/* 
    Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

    Each row must contain the digits 1-9 without repetition.
    Each column must contain the digits 1-9 without repetition.
    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    Note:

    A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    Only the filled cells need to be validated according to the mentioned rules.

    Input: board = 
        [["5","3",".",".","7",".",".",".","."]
        ,["6",".",".","1","9","5",".",".","."]
        ,[".","9","8",".",".",".",".","6","."]
        ,["8",".",".",".","6",".",".",".","3"]
        ,["4",".",".","8",".","3",".",".","1"]
        ,["7",".",".",".","2",".",".",".","6"]
        ,[".","6",".",".",".",".","2","8","."]
        ,[".",".",".","4","1","9",".",".","5"]
        ,[".",".",".",".","8",".",".","7","9"]]
    Output: true

    Input: board = 
        [["8","3",".",".","7",".",".",".","."]
        ,["6",".",".","1","9","5",".",".","."]
        ,[".","9","8",".",".",".",".","6","."]
        ,["8",".",".",".","6",".",".",".","3"]
        ,["4",".",".","8",".","3",".",".","1"]
        ,["7",".",".",".","2",".",".",".","6"]
        ,[".","6",".",".",".",".","2","8","."]
        ,[".",".",".","4","1","9",".",".","5"]
        ,[".",".",".",".","8",".",".","7","9"]]
        Output: false
    */

    // Three loops still or O(9*9)
    // Check row
    // Check column
    // Check 3 x 3 box
    
    // Board dimensions are constant so using a hash to keep track is not too bad memory used 9*9*9*n technically still O(n)

function isValidSudoku(board: string[][])  {

    // rows
    for(let i = 0; i < board.length; i++ ){

        let trackerArray: number[] = [0,0,0,0,0,0,0,0,0,0,]

        
        for(let columnPlace:number = 0; columnPlace < board.length; columnPlace++){

            const row = parseInt(board[i][columnPlace])


            if(row === NaN){
                
            }
            else if(trackerArray[row] === 0){


                trackerArray[row] = 1;
            }
            else if(trackerArray[row] === 1){


                return false
            }
        }
    }

    // columns
    for(let i = 0; i < board.length; i++ ){

        let trackerArray: number[] = [0,0,0,0,0,0,0,0,0,0,]

        
        for(let columnPlace:number = 0; columnPlace < board.length; columnPlace++){
            // console.log("column: ", board[columnPlace][i])

            const column = parseInt(board[columnPlace][i])


            if(column === NaN){
                
            }
            else if(trackerArray[column] === 0){


                trackerArray[column] = 1;
            }
            else if(trackerArray[column] === 1){


                return false
            }
        }
    }

    // boxes
    let trackerArray = [0,0,0,0,0,0,0,0,0,0,];

    for(let boxNumber = 0; boxNumber < 9; boxNumber++ ){

            
        trackerArray = [0,0,0,0,0,0,0,0,0,0,]
        

        for(let i = 0; i < 3; i++){

            let row = i%3 + (Math.trunc(boxNumber/3)*3)

            for(let column = (boxNumber*3)%9; column < (boxNumber*3)%9 + 3; column++){

                const currValue = parseInt(board[row][column])


                if(currValue === NaN){
                    
                }
                else if(trackerArray[currValue] === 0){


                    trackerArray[currValue] = 1;
                }
                else if(trackerArray[currValue] === 1){


                    return false
                }
                
            }


            
        }
        
        
    }
    return true

};

let board = 
    [["5","3",".",".","7",".",".",".","."]
    ,["6",".",".","1","9","5",".",".","."]
    ,[".","9","8",".",".",".",".","6","."]
    ,["8",".",".",".","6",".",".",".","3"]
    ,["4",".",".","8",".","3",".",".","1"]
    ,["7",".",".",".","2",".",".",".","6"]
    ,[".","6",".",".",".",".","2","8","."]
    ,[".",".",".","4","1","9",".",".","5"]
    ,[".",".",".",".","8",".",".","7","9"]]

let board2 = 
    [["5","3",".",".","7",".",".",".","."]
    ,["6",".","5","1","9","5",".",".","."]
    ,[".","9",".",".",".",".",".","6","."]
    ,["8",".",".",".","6",".",".",".","3"]
    ,["4",".",".","8",".","3",".",".","1"]
    ,["7",".",".",".","2",".",".",".","6"]
    ,[".","6",".",".",".",".","2","8","."]
    ,[".",".",".","4","1","9",".",".","5"]
    ,[".",".",".",".","8",".",".","7","9"]]

let board3 = 
[
    [".",".",".", ".","5",".", ".","1","."],
    [".","4",".", ".",".",".", ".",".","."],
    [".",".",".", ".",".","3", ".",".","1"],
    
    ["8",".",".", ".",".",".", ".","2","."],
    [".",".","2", ".","7",".", ".",".","."],
    [".","1","5", ".",".",".", ".",".","."],
    
    [".",".",".", ".",".","2", ".",".","."],
    [".","2",".", "9",".",".", ".",".","."],
    [".",".","4", ".",".",".", ".",".","."]
]

// isValidSudoku(board)
console.log(isValidSudoku(board))
console.log(isValidSudoku(board2))
console.log(isValidSudoku(board3))

// Neetcode Solution
/* function isValidSudoku2(board:string[][]) {
    const rows = {};
    const cols = {};
    const squares = {};

    // iterate over row
    for (let r = 0; r < 9; r++) {

        // iterate over columns
        for (let c = 0; c < 9; c++) {
            const num = board[r][c];

            if (num === '.') {
                continue;
            }

            const grid = `${Math.floor(r / 3)}${Math.floor(c / 3)}`;

            // A JavaScript Set is a collection of unique values.

                // Each value can only occur once in a Set.

                // A Set can hold any value of any data type.

            // if the set with the value of c (current column) does not exist creat an empty set at c in cols
            if (!cols[c]) {
                cols[c] = new Set();
            }
            // if the set with the value of r (current row) does not exist creat an empty set at value r in rows
            if (!rows[r]) {
                rows[r] = new Set();
            }

            // if the set with the value of grid (current grid rowc olumn) does not exist create an empty set at value grid in squares
            if (!squares[grid]) {
                squares[grid] = new Set();
            }

            if (
                rows[r].has(num) ||
                cols[c].has(num) ||
                squares[grid].has(num)
            ) {
                return false;
            }

            cols[c].add(num);
            rows[r].add(num);
            squares[grid].add(num);
        }
    }

    return true;
}
*/
