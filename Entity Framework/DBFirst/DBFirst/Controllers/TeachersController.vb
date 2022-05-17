Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports DBFirst

Namespace Controllers
    Public Class TeachersController
        Inherits System.Web.Mvc.Controller

        Private db As New SchoolEntities

        ' GET: Teachers
        Function Index() As ActionResult
            Return View(db.Teachers.ToList())
        End Function

        ' GET: Teachers/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim teacher As Teacher = db.Teachers.Find(id)
            If IsNothing(teacher) Then
                Return HttpNotFound()
            End If
            Return View(teacher)
        End Function

        ' GET: Teachers/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Teachers/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,Name,Age,Salary")> ByVal teacher As Teacher) As ActionResult
            If ModelState.IsValid Then
                db.Teachers.Add(teacher)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(teacher)
        End Function

        ' GET: Teachers/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim teacher As Teacher = db.Teachers.Find(id)
            If IsNothing(teacher) Then
                Return HttpNotFound()
            End If
            Return View(teacher)
        End Function

        ' POST: Teachers/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,Name,Age,Salary")> ByVal teacher As Teacher) As ActionResult
            If ModelState.IsValid Then
                db.Entry(teacher).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(teacher)
        End Function

        ' GET: Teachers/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim teacher As Teacher = db.Teachers.Find(id)
            If IsNothing(teacher) Then
                Return HttpNotFound()
            End If
            Return View(teacher)
        End Function

        ' POST: Teachers/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim teacher As Teacher = db.Teachers.Find(id)
            db.Teachers.Remove(teacher)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
