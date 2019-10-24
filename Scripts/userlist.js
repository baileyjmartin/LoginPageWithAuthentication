function UserListViewModel() {
    var self = this;

    self.userList = ko.observableArray();
}

let userListViewModel = new UserListViewModel();

$(function () {
    ko.applyBindings(userListViewModel);
    UpdateUsers();
});

function UpdateUsers() {
    $.ajax({
        url: "/User/GetUserList",
        type: "GET",
        success: function (data) {
            userListViewModel.userList(JSON.parse(data));
        }
    });
}

function DeleteUser(user) {
    $.ajax({
        url: "/User/DeleteUser",
        type: "DELETE",
        data: { 'id': user.Id },
        success: function () {
            UpdateUsers();
        }
    });
}