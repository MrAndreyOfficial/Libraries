# All functions
```
import { extendedMath } from './library.js';

console.log(extendedMath.isEven(10)); // true
console.log(extendedMath.isEven(5)); // false

console.log(extendedMath.isOdd(5)); // true
console.log(extendedMath.isOdd(8)); // false

console.log(extendedMath.areOnlyEven(...[30, 50, 70])); // true
console.log(extendedMath.areOnlyEven(...[35, 7, 73])); // false

console.log(extendedMath.areOnlyOdd(...[7, 57, 35])); // true
console.log(extendedMath.areOnlyOdd(...[4, 6, 8])); // false

const numbers = [10, 75, -500, -2, 700, -7525, 754];

numbers.sort();

console.log(numbers); // [-2, -500, -7500, 10, 700, 75]

console.log(extendedMath.binarySearch(numbers, 75)) // 5
```

## How to install:
1. Download library.js or clone this repository
2. Include file in html file (requires type="module" on the [script tag](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/script)) or js file
