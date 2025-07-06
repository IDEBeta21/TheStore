import uuid
from django.db import models
from django.utils import timezone

# Create your models here.
class StoreTypes(models.Model):
    name = models.CharField(max_length=50)

    class Meta:
        db_table = "store_types"

    def __str__(self):
        return (f"ID: {self.id} Type: {self.name}")

class Stores(models.Model):
    external_id = models.UUIDField(default=uuid.uuid4, editable=False, unique=True, auto_created=True)
    name = models.CharField(max_length=100)
    description = models.CharField(max_length=100)
    store_types = models.ForeignKey(StoreTypes, on_delete=models.CASCADE, related_name="stores_store_types")
    is_deleted = models.BooleanField
    created_at = models.DateTimeField(auto_now_add=True)
    created_by = models.CharField(max_length=50)
    updated_at = models.DateTimeField(null=True)
    updated_by = models.DateField(null=True)

    class Meta:
        db_table = "stores"

class ProductTypes(models.Model):
    name = models.CharField(max_length=50)

    class Meta:
        db_table = "product_types"

class Products(models.Model):
    external_id = models.UUIDField(default=uuid.uuid4, editable=False, unique=True, auto_created=True)
    store_id = models.ForeignKey(Stores, on_delete=models.CASCADE, related_name="products_stores")
    image = models.CharField(max_length=100)
    name = models.CharField(max_length=100)
    description = models.CharField(max_length=100)
    product_type = models.ForeignKey(ProductTypes, on_delete=models.CASCADE, related_name="products_product_types")
    price = models.DecimalField(max_digits=10, decimal_places=2)
    is_available = models.BooleanField
    is_deleted = models.BooleanField
    created_at = models.DateTimeField(auto_now_add=True)
    created_by = models.CharField(max_length=50)
    updated_at = models.DateTimeField(null=True)
    updated_by = models.DateField(null=True)

    class Meta:
        db_table = "products"

class Users(models.Model):
    external_id = models.UUIDField(default=uuid.uuid4, editable=False, unique=True, auto_created=True)
    name = models.CharField(max_length=255)
    username = models.CharField(max_length=100)
    password = models.BinaryField()
    password_salt = models.BinaryField()
    gender = models.CharField(max_length=1, null=True)
    birthdate = models.DateField()
    address = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    mobile_no = models.CharField(11)
    is_acc_deleted = models.BooleanField()
    created_at = models.DateTimeField()

    class Meta:
        db_table = "users"
    
class Orders(models.Model):
    external_id = models.UUIDField(default=uuid.uuid4, editable=False, unique=True, auto_created=True)
    product_id = models.ForeignKey(Products, on_delete=models.CASCADE, related_name="orders_products")
    user_id = models.ForeignKey(Users, on_delete=models.CASCADE, related_name="orders_users")
    transaction_done = models.BooleanField()
    created_at = models.DateField(default=timezone.now)
    updated_at = models.DateField(null=True)
    updated_by = models.CharField(max_length=255)

    class Meta:
        db_table = "orders"    