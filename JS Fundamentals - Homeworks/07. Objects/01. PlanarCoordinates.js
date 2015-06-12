var point = {
        X: 0,
        Y: 3
    },
    point2 = {
        X: 0,
        Y: 0
    },
    line = {
        p1: point,
        p2: point2,
    };

var lineTwo = {
        p1: {
            X: 0,
            Y: 0
        },
        p2: {
            X: 4,
            Y: 0
        },
    },
    lineThree = {
        p1: {
            X: 0,
            Y: 3
        },
        p2: {
            X: 4,
            Y: 0
        }
    };

var distance = distanceBetweenPoints(point, point2);

console.log(distance);

var result = canMakeTriangle(line, lineTwo, lineThree);

console.log('The three lines can make triangle? - ' + result);

function canMakeTriangle(lineOne, lineTwo, lineThree) {
    var lenArr = [];
    lenArr[0] = distanceBetweenPoints(lineOne.p1, lineOne.p2);
    lenArr[1] = distanceBetweenPoints(lineTwo.p1, lineTwo.p2);
    lenArr[2] = distanceBetweenPoints(lineThree.p1, lineThree.p2);
    lenArr.sort(function(len1, len2) {
        return len1 - len2;
    });

    if (lenArr[0] * lenArr[0] + lenArr[1] * lenArr[1] === lenArr[2] * lenArr[2]) {
        return true;
    } else {
        return false;
    }
}

function distanceBetweenPoints(p1, p2) {
    var xDiff = p1.X - p2.X,
        yDiff = p1.Y - p2.Y;
    var dist = Math.sqrt(xDiff * xDiff + yDiff * yDiff);

    return dist;
}
