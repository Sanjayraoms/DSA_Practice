function Fib(num) {
    if(num === 1 || num === 2) return 1;
    return Fib(num-1)+Fib(num-2);
}

function fib(n,memo = [undefined,1,1]) {
    if(memo[n]!==undefined) return memo[n];
    // if(n === 1 || n === 2) return 1;
    let res = fib(n-1,memo) + fib(n-2,memo);
    memo[n] = res;
    return res;
}
console.log(fib(100));