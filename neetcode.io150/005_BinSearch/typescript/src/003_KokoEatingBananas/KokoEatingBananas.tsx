/* 
    Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas. The guards have gone and will come back in h hours.

    Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.

    Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.

    Return the minimum integer k such that she can eat all the bananas within h hours.

    

    Example 1:

        Input: piles = [3,6,7,11], h = 8
        Output: 4

    Example 2:

        Input: piles = [30,11,23,4,20], h = 5
        Output: 30

    Example 3:

        Input: piles = [30,11,23,4,20], h = 6 
        Output: 23
*/

// Create a list of possible answers from 0 to to max of the array
// Do bin search on the answers
    // compare middle to h

function minEatingSpeed(piles: number[], h: number) {

    let endPoint = Math.max.apply(Math, piles);;
    let startPoint = 0;
    let middlePoint = Math.floor((endPoint + startPoint) / 2);

    if (piles.length === h) {
        return endPoint;
    }

    while (startPoint < endPoint) {
        
        let hours = 0;


        piles.forEach((value) => {

            hours += Math.ceil((value)/middlePoint)

        })

        if (hours > h) {
            startPoint = middlePoint + 1;
        } else {
            endPoint = middlePoint;
        }

        middlePoint = Math.floor((endPoint + startPoint) / 2);

    }
    return startPoint;
}

// neetcode.io answer
function minEatingSpeed2(piles: number[], h:number) {
    let l = 0;
    let r = Math.max.apply(Math, piles);

    if (piles.length === h) {
        return r;
    }

    while (l < r) {
        const m = Math.floor((l + r) / 2);
        let hours = 0;
        for (const pile of piles) {
            hours += Math.ceil(pile / m);
        }
        if (hours > h) {
            l = m + 1;
        } else {
            r = m;
        }
    }

    return l;
}

console.log(minEatingSpeed([30,11,23,4,20], 5))



