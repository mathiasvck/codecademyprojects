let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:
function generateTarget(){
    return Math.floor(Math.random()*9);
};

//console.log(generateTarget());

function compareGuesses(userGuess, computerGuess, target){
    const diff1 = Math.abs(userGuess- target);
    const diff2 = Math.abs(computerGuess- target);

    if (diff1 < diff2 ){
        return true;
    } else if (diff2 < diff1){
        return false;
    } else {
        return true;
    };
};

/*console.log(compareGuesses(2,3,1));
console.log(compareGuesses(2,3,4));
console.log(compareGuesses(2,2,1));*/

function updateScore(winner){
    if (winner === "human"){
        humanScore ++;
    } else if (winner === "computer"){
        computerScore ++;
    };
};

function advanceRound(){
    currentRoundNumber ++;
};