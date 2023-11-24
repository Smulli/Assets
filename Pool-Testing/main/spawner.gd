extends Node3D

class_name Spawner

var bullet : PackedScene = preload("res://scene/scene.tscn")
var bullet2 : PackedScene = preload("res://scene/scene.tscn")
var spawn_timer : SpawnTimer = SpawnTimer.new()
var pool : ObjectPool
var pool2 : ObjectPool

func _ready() :
	pool = ObjectPool.new(bullet, 4)
	pool2 = ObjectPool.new(bullet2, 10)
	
	add_child(spawn_timer)
	add_child(pool)
	add_child(pool2)

func spawn() :
	var obj = pool.get_instance()
