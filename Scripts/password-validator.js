var lettersDigitsRegEx = /([a-zA-Z])([0-9])/;
var repeatCharactersRegEx = /(.{2,})\1/;

$(function () {
    ko.applyBindings(new PasswordViewModel());
});

function PasswordViewModel() {
    var self = this;

    self.password = ko.observable("");
    self.correctLength = ko.computed(function() {
        return (self.password().length > 4 && self.password().length < 13);
    });
    self.lettersDigits = ko.computed(function() {
        return lettersDigitsRegEx.test(self.password());
    });
    self.repeatCharacters = ko.computed(function () {
        return repeatCharactersRegEx.test(self.password());
    });
}