var number = 719,
    firstDigit = number % 10;
number = Math.floor(number / 10);
var secondDigit = number % 10;
number = Math.floor(number / 10);
var thirdDigit = number % 10,
    result = '';

if (thirdDigit !== 0) {
    switch (thirdDigit) {
        case 1:
            result += 'one hunderd';
            break;
        case 2:
            result += 'two hunderd';
            break;
        case 3:
            result += 'three hunderd';
            break;
        case 4:
            result += 'four hunderd';
            break;
        case 5:
            result += 'five hunderd';
            break;
        case 6:
            result += 'six hunderd';
            break;
        case 7:
            result += 'seven hunderd';
            break;
        case 8:
            result += 'eight hunderd';
            break;
        case 9:
            result += 'nine hunderd';
            break;
    }

    if (secondDigit !== 0 || firstDigit !== 0) {
        result += ' and ';
    }
}

if (secondDigit !== 0) {
    switch (secondDigit) {
        case 2:
            result += 'twenty';
            break;
        case 3:
            result += 'thirty';
            break;
        case 4:
            result += 'fourty';
            break;
        case 5:
            result += 'fifty';
            break;
        case 6:
            result += 'sixty';
            break;
        case 7:
            result += 'seventy';
            break;
        case 8:
            result += 'eighty';
            break;
        case 9:
            result += 'ninety';
            break;
    }

    if (firstDigit !== 0 && secondDigit !== 1) {
        result += ' ';
    }
}

if (secondDigit === 1) {
    switch (firstDigit) {
        case 0:
            result += 'ten';
            break;
        case 1:
            result += 'eleven';
            break;
        case 2:
            result += 'twelve';
            break;
        case 3:
            result += 'thirteen';
            break;
        case 4:
            result += 'fourteen';
            break;
        case 5:
            result += 'fifteen';
            break;
        case 6:
            result += 'sixteen';
            break;
        case 7:
            result += 'seventeen';
            break;
        case 8:
            result += 'eighteen';
            break;
        case 9:
            result += 'nineteen';
            break;
    }
} else {
    switch (firstDigit) {
        case 0:
            result += 'zero';
            break;
        case 1:
            result += 'one';
            break;
        case 2:
            result += 'two';
            break;
        case 3:
            result += 'three';
            break;
        case 4:
            result += 'four';
            break;
        case 5:
            result += 'five';
            break;
        case 6:
            result += 'six';
            break;
        case 7:
            result += 'seven';
            break;
        case 8:
            result += 'eight';
            break;
        case 9:
            result += 'nine';
            break;
    }
}

console.log(result);
