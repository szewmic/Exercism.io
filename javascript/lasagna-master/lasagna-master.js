/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

const MESSAGES = {
  LASAGNA_DONE: 'Lasagna is done.',
  LASAGNA_NOT_DONE: 'Not done, please wait.',
  INVALID_TIMER: 'You forgot to set the timer.'
};

const cookingStatus = (timer) => {
  if (timer === 0) {
    return MESSAGES.LASAGNA_DONE;
  }
  
  if (!timer) {
    return MESSAGES.INVALID_TIMER;
  };
  
  return MESSAGES.LASAGNA_NOT_DONE;
};

const preparationTime = (layers, time = 2) => layers.length * time;

const QUANTITIES = {
  noodles: 50,
  sauce: 0.2
};

const quantities = (layers) => {
  const result = {
    noodles: 0,
    sauce: 0
  };
  
  layers.forEach(layer => {
    if (QUANTITIES[layer]) {
      if (!result[layer]) {
        result[layer] = 0;
      };
      result[layer] += QUANTITIES[layer];
    }
  });
  return result;
};

const addSecretIngredient = (friendsList, myList) => {
  myList.push(friendsList[friendsList.length - 1]);
};

const scaleRecipe = (recipe, scale = 2) => {
  const normalizedScale = scale / 2;
  return Object.entries(recipe).reduce((p, [k, v]) => ({ ...p, [k]: v * normalizedScale }), {});
};

export { cookingStatus, preparationTime, quantities, addSecretIngredient, scaleRecipe };
