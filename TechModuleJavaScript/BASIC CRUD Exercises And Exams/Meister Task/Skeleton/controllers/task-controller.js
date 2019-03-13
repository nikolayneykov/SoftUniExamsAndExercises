const Task = require('../models/Task');

module.exports = {
  getIndex: function (req, res) {
    Task.find({}).then(function (tasks) {
      let openTasks = tasks.filter(t => t.status === 'Open');
      let inProgressTasks = tasks.filter(t => t.status === 'In Progress');
      let finishedTasks = tasks.filter(t => t.status === 'Finished');
      res.render('index', { openTasks, inProgressTasks, finishedTasks });
    });
  },
  getCreate: function (req, res) {
    res.render('create');
  },
  postCreate: function (req, res) {
    let task = req.body;
    Task.create(task).then(function () {
      res.redirect('/');
    });
  },
  getEdit: function (req, res) {
    let id = req.params.id;
    Task.findById(id).then(function (task) {
      task.open = task.status === 'Open';
      task.inProgress = task.status === 'In Progress';
      task.finished = task.status === 'Finished';

      res.render('edit', { task });
    });
  },
  postEdit: function (req, res) {
    let id = req.params.id;
    let newTask = req.body;
    Task.findByIdAndUpdate(id, newTask).then(function () {
       res.redirect('/');
    });
  },
  getDelete: function (req, res) {
    let id = req.params.id;
    Task.findById(id).then(function (task) {
      task.open = task.status === 'Open';
      task.inProgress = task.status === 'In Progress';
      task.finished = task.status === 'Finished';

      res.render('delete', { task });
    });
  },
  postDelete: function (req, res) {
    let id = req.params.id;
    Task.findByIdAndRemove(id).then(function () {
       res.redirect('/');
    });
  }
};