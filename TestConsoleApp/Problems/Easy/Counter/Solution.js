/**
 * @param {number} n
 * @return {Function} counter
 */
var createCounter = function (n) {
    var count = 0;

    return function () {
        var result = n + count;
        count++;

        return result;
    };
};

/** 
 * const counter = createCounter(10)
 * counter() // 10
 * counter() // 11
 * counter() // 12
 */