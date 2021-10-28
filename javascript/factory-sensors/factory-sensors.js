// @ts-check
const MAX_HIMIDITY_PERCENTAGE = 70;
const MIN_OVERHEATING_TEMPERATURE = 500;
const MAX_OVERHEATING_TEMPERATURE = 600;

export class ArgumentError extends Error {}

export class OverheatingError extends Error {
  constructor(temperature) {
    super(`The temperature is ${temperature} ! Overheating !`);
    this.temperature = temperature;
  }
}

/**
 * Check if the humidity level is not too high.
 *
 * @param {number} humidityPercentage
 * @throws {Error}
 */
export function checkHumidityLevel(humidityPercentage) {
  if (humidityPercentage > MAX_HIMIDITY_PERCENTAGE) {
    throw new Error('Wrong humidity percentage');
  }
}

class Validator {
  validate(value) {
    throw new Error("Implement validate function"); 
  }
}

class SensorBrokenValidator extends Validator {
  validate(value) {
    if (value === null) {
       throw new ArgumentError("Sensor broken");
    };
  }
}

class OverheatingValidator extends Validator {
   validate(value) {
    if (value > MIN_OVERHEATING_TEMPERATURE) {
      throw new OverheatingError(value);
    };
  }
}

class TemperatureValidatorsManager {
  validators = [];

  constructor(validators) {
    validators.forEach(validator => this.registerValidator(validator));
  }

  registerValidator(validator) {
    if (!(validator instanceof Validator)) {
      throw new Error("You can only register classes inherited from Validator");
    };
    this.validators.push(validator);
  }

  checkAllValid(value) {
     this.validators.forEach(validator => {
       validator.validate(value);
     });
  }
}

const temperatureValidatorsManager = new TemperatureValidatorsManager([
  new SensorBrokenValidator(),
  new OverheatingValidator()
]);

/**
 * Check if the temperature is not too high.
 *
 * @param {number|null} temperature
 * @throws {ArgumentError|OverheatingError}
 */
export function reportOverheating(temperature) {
  temperatureValidatorsManager.checkAllValid(temperature);
}

/**
 *  Triggers the needed action depending on the result of the machine check.
 *
 * @param {{
 * check: function,
 * alertDeadSensor: function,
 * alertOverheating: function,
 * shutdown: function
 * }} actions
 * @throws {ArgumentError|OverheatingError|Error}
 */
function handleError(err, actions) {
  if (err instanceof ArgumentError) {
    actions.alertDeadSensor();
  } else if (err instanceof OverheatingError) {
    if (err.temperature < MAX_OVERHEATING_TEMPERATURE) {
      actions.alertOverheating();
    } else {
      actions.shutdown();
    }
  } else throw err;
};

export function monitorTheMachine(actions) {
  try {
    actions.check();
  } catch (err) {
    handleError(err, actions);
  };
}
