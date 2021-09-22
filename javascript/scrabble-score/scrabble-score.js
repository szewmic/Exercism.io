//
// This is only a SKELETON file for the 'Scrabble Score' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
const VALUE_TO_LETTERS_MAP = {
  1: ['A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'],
  2: ['D', 'G'],
  3: ['B', 'C', 'M', 'P'],
  4: ['F', 'H', 'V', 'W', 'Y'],
  5: ['K'],
  8: ['J', 'X'],
  10: ['Q', 'Z']
};

const computeValuesBoard = (map) => {
  let valuesBoard = {};
  for (const [key, values] of Object.entries(map)) {
    values.forEach(value => {
      valuesBoard[value] = parseInt(key);
    });
  };
  return valuesBoard;
};

export const valuesBoard = computeValuesBoard(VALUE_TO_LETTERS_MAP);

export const score = (word) => {
  const upperCasedLetters = [...word.toUpperCase()];
  if (upperCasedLetters.length === 0) {
    return 0;
  };
  return upperCasedLetters.reduce((prevVal, currVal) => valuesBoard[prevVal] + valuesBoard[currVal], valuesBoard[upperCasedLetters[0]]);
};
