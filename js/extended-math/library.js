export const extendedMath = {
    isEven: number => {
        return number % 2 === 0;
    },
    areOnlyEven: (...numbers) => {
        return numbers.every(number => extendedMath.isEven(number));
    },
    isOdd: number => {
        return number % 2 !== 0;
    },
    areOnlyOdd: (...numbers) => {
        return numbers.every(number => extendedMath.isOdd(number));
    },
    binarySearch: (values, valueForSearch) => {
        if (Array.isArray(values)) {
            let lower = 0;
            let upper = values.length;

            while (lower <= upper) {
                const middle = Math.floor((lower + upper) / 2);

                if (values[middle] === valueForSearch) {
                    return middle;
                }

                if (valueForSearch < values[middle]) {
                    upper = middle - 1;
                }
                else {
                    lower = middle + 1;
                }
            }
        }

        return -1;
    }
}
