import './Task.css'

function TaskCard({ ready }) {
    return <div className="card">
        <h1>Mi primer tarea</h1>{
            <span className={ready ? "Green" : "Red" }>
                {ready ? "Tarea realizada" : "Tarea pendiente"}
            </span>
        }
    </div>
}

export default TaskCard