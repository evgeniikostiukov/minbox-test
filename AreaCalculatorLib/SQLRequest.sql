--Считаю, что более подходящий вариант - это создать таблицу с полями product_id, category_id и в нее класть данные о продуктах и их категориях.
-- Так мы избежим избыточность данных, а так же получим связь многие-ко-многим.

CREATE TABLE categories
(
    id   INT PRIMARY KEY IDENTITY,
    name VARCHAR
);

CREATE TABLE products
(
    id   INT PRIMARY KEY IDENTITY,
    name VARCHAR NOT NULL
);

CREATE TABLE product_categories
(
    id INT PRIMARY KEY IDENTITY,
    product_id REFERENCES products (id),
    category_id REFERENCES categories (id)
) INSERT INTO categories (name)
VALUES ('Овощи'),
       ('Фрукты'),
       ('Мясо');

INSERT INTO products (name)
VALUES ('Картофель'),
       ('Манго'),
       ('Куриное филе'),
       ('Говяжья вырезка'),
       ('Туалетное мыло');

INSERT INTO product_categories (product_id, category_id)
VALUES (1, 1),
       (1, 2),
       (2, 2),
       (3, 3)

SELECT prod.name, cat.name
FROM products prod
         LEFT JOIN product_categories pc on prod.id = pc.product_id
         LEFT JOIN categories cat on pc.category_id = cat.id