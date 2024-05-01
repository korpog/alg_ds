class Node:
    def __init__(self, value):
        self.left = None
        self.right = None
        self.val = value


def insert(root, value):
    if root is None:
        return Node(value)
    else:
        if root.val < value:
            root.right = insert(root.right, value)
        else:
            root.left = insert(root.left, value)
    return root


def inorder(root):
    if root:
        inorder(root.left)
        print(root.val, end=' ')
        inorder(root.right)


def preorder(root):
    if root:
        print(root.val, end=' ')
        preorder(root.left)
        preorder(root.right)


def postorder(root):
    if root:
        postorder(root.left)
        postorder(root.right)
        print(root.val, end=' ')


def level_order(root):
    if root is None:
        return

    queue = []
    queue.append(root)

    while (len(queue) > 0):
        print(queue[0].val, end=' '),
        node = queue.pop(0)

        if node.left is not None:
            queue.append(node.left)

        if node.right is not None:
            queue.append(node.right)


def search(root, value):
    if root is None or root.val == value:
        return root
    if root.val < value:
        return search(root.right, value)
    return search(root.left, value)


def delete(root, value):
    if root is None:
        return root
    if value < root.val:
        root.left = delete(root.left, value)
    elif (value > root.val):
        root.right = delete(root.right, value)
    else:
        if root.left is None:
            return root.right
        elif root.right is None:
            return root.left
        temp = min_value(root.right)
        root.value = temp.value
        root.right = delete(root.right, temp.value)
    return root

def min_value(node):
    min = node
    while (min.left is not None):
        min = min.left
    return min


r = Node(50)
r = insert(r, 30)
r = insert(r, 20)
r = insert(r, 40)
r = insert(r, 70)
r = insert(r, 60)
r = insert(r, 80)

print("Inorder: ")
inorder(r)
print()

print("Preorder: ")
preorder(r)
print()

print("Postorder: ")
postorder(r)
print()

print("Level order: ")
level_order(r)
print()
