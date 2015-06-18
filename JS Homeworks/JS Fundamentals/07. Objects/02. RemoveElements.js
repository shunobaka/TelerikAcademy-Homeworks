Array.prototype.remove = function(numberToRemove) {
    var index,
        len = this.length;

    for (index = 0; index < len; index += 1) {
        if (this[index] === numberToRemove) {
            this.splice(index, 1);
            index -= 1;
        }
    }
};

var arr = [1, 2, 5, 54, 32, 1, 4, 4, 1, 1, 1, 54, 3, 65, 4];

arr.remove(1);
console.log(arr);
