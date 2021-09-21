//
// This is only a SKELETON file for the 'Armstrong numbers' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isArmstrongNumber = (number) => {
  let numberStr = number.toString();
  let numberLength = numberStr.length;
  let result = [...numberStr].reduce((prev, curr) => {return prev + Number(curr) * numberLength});
  return result === number;
};
