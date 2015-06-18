console.log('Properties in window:');
findProperties(window);
console.log('Properties in document:');
findProperties(document);
console.log('Properties in navigator:');
findProperties(navigator);

function findProperties(obj) {
    var prop,
        min = 0,
        max = 0;

    for (var prop in obj) {
        if (!min) {
            min = prop;
        }
        if (!max) {
            max = prop;
        }
        if (prop < min) {
            min = prop;
        }
        if (prop > max) {
            max = prop;
        }
    }

    console.log('The smallest property is: ' + min);
    console.log('The largest property is: ' + max);
}