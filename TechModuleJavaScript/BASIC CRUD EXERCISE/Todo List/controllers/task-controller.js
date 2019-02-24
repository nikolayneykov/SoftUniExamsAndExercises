const Task = require('../models/Task');

module.exports = {
  getIndex: function (req, res) {
    Task.find({})
      .then((allTasks) => {
        const openTasks = allTasks.filter(x => x.status === 'Open');
        const inProgressTasks = allTasks.filter(x => x.status === 'In Progress');
        const finishedTasks = allTasks.filter(x => x.status === 'Finished');
        res.render('index', { openTasks, inProgressTasks, finishedTasks });
      });
  },
  getCreate: function (req, res) {
    res.render('create');
  },
  postCreate: function (req, res) {
    let title = req.body.title;
    let status = req.body.status;

    Task.create({
      title: title,
      status: status
    }).then(() => { res.redirect('/'); });
  },
  getEdit: function (req, res) {
    const id = req.params.id;
    Task.findById(id)
      .then((task) => {
        task.open = task.status === 'Open';
        task.inProgress = task.status === 'In Progress';
        task.finished = task.status === 'Finished';
        res.render('edit', { task });
      });
  },
  postEdit: function (req, res) {
    const id = req.params.id;
    Task.findByIdAndUpdate(id, req.body)
      .then(() => { res.redirect('/'); });
  },
  getDelete: function (req, res) {
    const id = req.params.id;
    Task.findById(id)
      .then((task) => {
        task.open = task.status === 'Open';
        task.inProgress = task.status === 'In Progress';
        task.finished = task.status === 'Finished';
        res.render('delete', { task });
      });
  },
  postDelete: function (req, res) {
    const id = req.params.id;
    Task.findByIdAndDelete(id)
      .then(() => { res.redirect('/'); });
  }
};