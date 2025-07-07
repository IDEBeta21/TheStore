from django.shortcuts import render
from thestore.models import StoreTypes

# Create your views here.
def index(request):
    store_types = StoreTypes.objects.all()
    store_type_context = {'store_types':store_types}
    return render(request, 'store_types/index.html', store_type_context)