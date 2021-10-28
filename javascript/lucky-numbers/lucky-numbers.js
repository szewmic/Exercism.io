// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
Array.prototype.sum = function (startSum = 0) {
  return Number(this.reduce((prevVal, currVal) => prevVal += currVal, '')) + startSum;
};

export function twoSum(array1, array2) {
  return array2.sum(array1.sum());
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean}  whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  const digits = [...value.toString()];

  while (digits.length > 0) {
    let firstDigit = digits.shift();
    let lastDigit = digits.pop();
    if (firstDigit && lastDigit && firstDigit !== lastDigit) {
      return false;
    }
  }
  return true;
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  if (!input) {
    return 'Required field';
  } else if (!Number(input)) {
    return 'Must be a number besides 0'
  }
  return '';
}
