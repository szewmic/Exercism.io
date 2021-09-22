//
// This is only a SKELETON file for the 'Armstrong Numbers' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isArmstrongNumber = (number) => {
  let digits = [...number.toString()].map(nr => parseInt(nr));
  let digitsPoweredSum = digits.reduce((prevVal, currVal) => prevVal + Math.pow(currVal, digits.length), 0);
  return number === digitsPoweredSum;
};
