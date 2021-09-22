//
// This is only a SKELETON file for the 'React' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

class BaseCell {
  constructor() {
    this._value = null;
    this._subscribers = [];
  }

  subscribe(handler) {
    this._subscribers.push(handler);
  }

  _notify(value) {
     this._subscribers.forEach(handler => handler(value));
  }
  
  get value() {
    return this._value;
  }
}

export class InputCell extends BaseCell {
  constructor(value) {
    super();
    this._value = value;
  }

  setValue(value) {
    this._value = value;
    this._notify(this._value);
  }
}

export class ComputeCell extends BaseCell {
  constructor(inputCells, fn) {
    super();
    this._inputCells = inputCells;
    this._fn = fn;
    this._callbacks = [];
    this._previousState = this.value;
    this.inputCellValueChanged = this.inputCellValueChanged.bind(this);
    this._inputCells.forEach(ic => {
      if (ic instanceof BaseCell)
        ic.subscribe(this.inputCellValueChanged);
    });
  }

  addCallback(cb) {
    this._callbacks.push(cb);
  }

  removeCallback(cb) {
    let index = this._callbacks.findIndex(x => x === cb);
    this._callbacks = this._callbacks.splice(index + 1, 1);
  }

  inputCellValueChanged(newValue) {
    if (this.value !== this._previousState) {
      this._notify(newValue);
      this._previousState = this.value;
      this._callbacks.forEach(cb => cb.callback(this));
    }
  }
  
  get value() {
    return this._fn(this._inputCells);
  }
}

export class CallbackCell {
  constructor(fn) {
    this._fn = fn;
    this._values = [];
  }

  callback(newValue) {
    let computedValue = this._fn(newValue);
    this._values.push(computedValue);
  }

  get values() {
    return this._values;
  }
}
