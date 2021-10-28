// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Calculates the total bird count.
 *
 * @param {number[]} birdsPerDay
 * @returns {number} total bird count
 */
export function totalBirdCount(birdsPerDay) {
    return birdsPerDay.reduce((prevVal, currVal) => currVal + prevVal);
}

/**
 * Calculates the total number of birds seen in a specific week.
 *
 * @param {number[]} birdsPerDay
 * @param {number} week
 * @returns {number} birds counted in the given week
 */
const DAYS_IN_WEEK = 7;
export function birdsInWeek(birdsPerDay, week) {
    let dayOffset = DAYS_IN_WEEK * (week - 1);
    let count = 0;
    for (let i = 0; i < 7; i++) {
        let dayIndexWithOffset = i + dayOffset;
        if (birdsPerDay[dayIndexWithOffset] !== undefined) {
            count += birdsPerDay[dayIndexWithOffset];
        } else {
            break;
        }
    }
    return count;
}

/**
 * Fixes the counting mistake by increasing the bird count
 * by one for every second day.
 *
 * @param {number[]} birdsPerDay
 * @returns {number[]} corrected bird count data
 */

Array.prototype.mapEveryFew = function(leap, callback) {
    this.forEach((item, index) => {
        if (index % leap === 0) {
            this[index] = callback(item);
        }
    });
    return this;
};

export function fixBirdCountLog(birdsPerDay) {
    return birdsPerDay.mapEveryFew(2, item => item + 1);
}